using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class FireOrb : MonoBehaviour {

    ParticleSystem m_System;
    ParticleSystem.Particle[] m_Particles;

    private Quaternion rotation;
    private Vector3 radius = new Vector3(25, 0, 0);

    void LateUpdate()
    {
        InitializeIfNeeded();

        int numParticlesAlive = m_System.GetParticles(m_Particles);

        for (int i = 0; i < numParticlesAlive; i++)
        {

            rotation.eulerAngles += new Vector3(0, (1) * Time.deltaTime, 0);
            m_Particles[i].position = rotation * radius;

        }
        m_System.SetParticles(m_Particles, numParticlesAlive);
    }
    void InitializeIfNeeded()
    {
        if (m_System == null)
            m_System = GetComponent<ParticleSystem>();

        if (m_Particles == null || m_Particles.Length < m_System.main.maxParticles)
            m_Particles = new ParticleSystem.Particle[m_System.main.maxParticles];
    }
}

