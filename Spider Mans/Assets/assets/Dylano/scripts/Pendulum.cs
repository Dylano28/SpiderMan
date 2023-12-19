using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[System.Serializable]
public class Pendulum
{
    public Transform Sp_tr;
    public tetcher tetcher;
    public Arm arm;
    public Sp sp;
    Vector3 previousPosition;


    public void Initialise()
    {
        Sp_tr.transform.parent = tetcher.tetcher_tr;
        arm.lenght = Vector3.Distance(Sp_tr.transform.localPosition, tetcher.position);
    }

    public Vector3 MoveSp(Vector3 pos, float time)
    {
        sp.velocity += GetConstrainedVelocity(pos, previousPosition, time);
        sp.ApplyGravity();
        sp.ApplyDamping();
        sp.CapMaxSpeed();

        pos += sp.velocity * time;
        if (Vector3.Distance(pos, tetcher.position) < arm.lenght)
        {
            pos = Vector3.Normalize(pos - tetcher.position) * arm.lenght;
            arm.lenght = (Vector3.Distance(pos, tetcher.position));
            return pos;
        }

        previousPosition = pos;
        return pos;

    }

    public Vector3 MoveSp(Vector3 pos, Vector3 prevPos, float time)
    {
        sp.velocity += GetConstrainedVelocity(pos, prevPos, time);
        sp.ApplyGravity();
        sp.ApplyDamping();
        sp.CapMaxSpeed();

        pos += sp.velocity * time;
        if (Vector3.Distance(pos, tetcher.position) < arm.lenght)
        {
            pos = Vector3.Normalize(pos - tetcher.position) * arm.lenght;
            arm.lenght = (Vector3.Distance(pos, tetcher.position));
            return pos;
        }

        previousPosition = pos;
        return pos;

    }

    public Vector3 GetConstrainedVelocity(Vector3 currentPos, Vector3 previousPosition, float time)
    {
        float distanceToTetcher;
        Vector3 contrainedPosition;
        Vector3 predictedPosition;
        distanceToTetcher = Vector3.Distance(currentPos, tetcher.position);

        if (distanceToTetcher > arm.lenght)
        {
            contrainedPosition = Vector3.Normalize(currentPos - tetcher.position) * arm.lenght;
            predictedPosition = (contrainedPosition - previousPosition) / time;
            return predictedPosition;
        }
        return Vector3.zero;

    }
    public void SwitchTetcher(Vector3 newPosition)
    {
        Sp_tr.transform.parent = null;
        tetcher.tetcher_tr.position = newPosition;
        Sp_tr.transform.parent = tetcher.tetcher_tr;
        tetcher.position = tetcher.tetcher_tr.InverseTransformPoint(newPosition);
        arm.lenght = Vector3.Distance(Sp_tr.transform.localPosition, tetcher.position);
    }
    public Vector3 Fall(Vector3 pos, float time)
    {
        sp.ApplyGravity();
        sp.ApplyDamping();
        sp.CapMaxSpeed();

        pos += sp.velocity * time;
        return pos;
    }
}
