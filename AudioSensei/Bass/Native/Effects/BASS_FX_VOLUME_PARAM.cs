﻿namespace AudioSensei.Bass.Native.Effects
{
    internal struct BASS_FX_VOLUME_PARAM : IEffect
    {
        public float fTarget;
        public float fCurrent;
        public float fTime;
        public Curve lCurve;
    }
}
