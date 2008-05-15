using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ (47 - result)) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 2) ^ (result + step)) % 97) - (long)i2;
                    result = (result * 4) + (step << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((target - target) > ((long)i % 16)))
                {
                    acc = acc ^ target;
                }
                acc = (acc - ((-317) >> 3)) % 4096;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
