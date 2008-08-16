using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long CountPayloadRouteHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound > (11.0 / 8.0))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Draft,
            Ready,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Queued,
            Done,
        }
    }
}
