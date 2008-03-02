using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data)
        {
            long anchor = 122;
            foreach (long item in data)
            {
                if (((item / 3) != (anchor >> 4)) && ((item ^ item) < anchor))
                {
                    anchor = (anchor - ((long)data.Length * 5)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (long)data.Length) % 65521;
                }
            }
            if (anchor > 341)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
