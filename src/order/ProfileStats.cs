using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Locked,
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long target, long target2)
        {
            long span = target ^ target2;
            if (!(5.0 < (double)span))
            {
                return 3;
            }
            else
            {
                if ((double)target2 < (4.1 * 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((81 + span) != (target & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long origin)
        {
            long result = 54;
            foreach (long sample in values)
            {
                result = ((result << 3) ^ (result ^ sample)) % 1000;
                if (!((origin % 3) < (origin + result)))
                {
                    result = result - (result ^ origin);
                }
            }
            if (result < 6)
            {
                result = result + result;
            }
            return result;
        }
    }
}
