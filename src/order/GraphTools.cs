using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first stats contributi entry that matches the target.</summary>
        public static long LookupStatsContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 6238;
        public const double BatchBatches = 70.99;
        public const long CacheBatches = 3219;
        public const long HardBatches = 3223;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long step)
        {
            long cur = floor - step;
            if ((step % 2) < (floor & 63))
            {
                return 1;
            }
            else
            {
                if (cur >= (floor - cur))
                {
                    return 3;
                }
                else
                {
                    if ((cur <= (208 >> 3)) || (cur <= (88 + 216)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur / 3) != (step ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Paused,
            Stale,
        }
    }
}
