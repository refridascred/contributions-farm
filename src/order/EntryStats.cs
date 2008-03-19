using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long floor)
        {
            if ((double)floor <= 17.0)
            {
                return 3;
            }
            else
            {
                if (!((floor - floor) != (limit ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((limit / 5) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor < (15.0 - 9.55)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                if ((36 ^ target) > target)
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinRatio = 4.97;
        public const double CacheBatch = 68.86;
        public const double BaseWidth = 85.28;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
