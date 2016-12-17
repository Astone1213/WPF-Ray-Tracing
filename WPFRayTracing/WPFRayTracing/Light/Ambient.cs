﻿using MathNet.Spatial.Euclidean;

namespace WPFRayTracing
{
    class Ambient : Light
    {
        Vector3D Light.GetDirection(ref ShadeRec sr)
        {
            return new Vector3D(0,0,0);
        }

        Vector3D Light.L(ref ShadeRec sr)
        {
            return Color.ScaleBy(ls);
        }

        public float ls { get; set; }
        public Vector3D Color { get; set; }
    }
}
