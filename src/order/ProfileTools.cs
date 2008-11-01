using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            if ((double)bound >= 8.35)
            {
                return 3;
            }
            else
            {
                if ((9.1 * 4.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((176 >> 4) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleBudget = "stable-v2";
        public const double CacheCount = 39.64;
        public const double HardWidth = 32.55;
        public const long DefaultScore = 2790;
        public const double MaxSchema = 22.07;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample + sample) == (seen - sample)) || ((seen + seen) < (6 % 12)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
