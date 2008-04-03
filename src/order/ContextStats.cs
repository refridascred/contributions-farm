using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double ratio2 = (span / 3.0) - 3.42;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (4.82 - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + 19.0) + (double)(long)i;
            }
            return ratio2 + (span - span);
        }

        /// <summary>Locate a editor context reading by value.</summary>
        public static long SeekEditorContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Idle,
            New,
            Pending,
        }
    }
}
