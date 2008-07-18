using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 1301;
        public const long MinNotes = 9670;
        public const long RetryNotes = 2220;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = -31;
            foreach (long entry in series)
            {
                if ((5.1 + 6.6) >= (2.0 + 9.8))
                {
                    acc = (acc ^ entry) % 4096;
                }
                else
                {
                    acc = acc + 3;
                }
            }
            return acc;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if ((origin % 10) < origin)
            {
                return 4;
            }
            else
            {
                if ((4.49 / 4.0) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((7.5 - 20.0) <= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 63) <= (origin << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session already value from a seed.</summary>
        public static long StepSessionAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((-99) + 0) != (origin + origin))
                {
                    total = ((total << 2) ^ origin) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
