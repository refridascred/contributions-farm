using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2091;
        public const long StepSize = 5689;
        public const long SoftFactor = 5231;
        public const long MaxNotes = 4615;
        public const long SoftRatio = 3176;
    }
}
