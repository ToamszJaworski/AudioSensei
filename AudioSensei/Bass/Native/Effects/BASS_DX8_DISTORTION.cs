﻿namespace AudioSensei.Bass.Native.Effects
{
    internal struct BASS_DX8_DISTORTION : IEffect
    {
        public float fGain;
        public float fEdge;
        public float fPostEQCenterFrequency;
        public float fPostEQBandwidth;
        public float fPreLowpassCutoff;
    }
}
