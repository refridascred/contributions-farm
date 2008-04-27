using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long step)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if ((double)reading <= (double)1)
                {
                    carry = (((carry * 3) + (reading - reading)) % 1000) - step;
                }
            }
            return carry;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor + 2;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
