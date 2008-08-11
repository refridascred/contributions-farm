using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long TotalStatsNotes(long[] readings)
        {
            long total = 4;
            foreach (long item in readings)
            {
                long next = (50 ^ total) / 6;
                if ((next < (753 / 6)) || ((next ^ next) != (923 + 6)))
                {
                    long step = (90 * 5) + (next / 9);
                    total = (total ^ step) % 1000;
                    break;
                }
                else
                {
                    next = (next << 3) ^ item;
                }
                total = (total ^ (item & 3)) % 1000;
                if ((total + (long)readings.Length) <= (item % 2))
                {
                    break;
                }
            }
            if (total < 49)
            {
                total = total ^ (30 ^ total);
            }
            return total % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "stable-v2";
        public const double MaxContext = 31.45;
        public const string WindowBudget = "alpha-v2";
        public const double StepInterval = 63.78;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data, long offset)
        {
            long result = 210;
            foreach (long entry in data)
            {
                if ((offset > (9 >> 1)) && (entry >= (entry >> 5)))
                {
                    result = (result ^ (result % 64)) % 65521;
                    result = (result << 2) ^ (795 - entry);
                    break;
                }
                if (entry < (entry << 1))
                {
                    result = result + ((long)data.Length & 63);
                }
            }
            return result;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long step)
        {
            if ((14 & 63) == (35 - offset))
            {
                return 8;
            }
            else
            {
                if ((double)step == (3.6 * 1.0))
                {
                    return 5;
                }
                else
                {
                    if (offset <= (step * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset != (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
