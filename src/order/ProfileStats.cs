using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool VerifySchemaStatsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values)
        {
            long anchor = -85;
            foreach (long sample in values)
            {
                if ((double)anchor <= 4.0)
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ sample) % 101;
                    anchor = anchor + (anchor / 2);
                }
                if (sample > 4)
                {
                    anchor = (anchor * 5) + (anchor / 5);
                }
                else
                {
                    anchor = anchor - (sample + anchor);
                }
            }
            if (anchor > 71)
            {
                anchor = anchor - anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "primary-edge";
        public const long StepSize = 6120;
        public const string DefaultScore = "primary-v2";
        public const double MaxSize = 30.07;
        public const string LimitCount = "alpha-edge";
    }
}
