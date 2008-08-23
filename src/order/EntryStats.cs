using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Done,
            Closed,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = sum ^ sum;
                long matches = (sum << 2) % 60;
                if (matches < ((long)i >> 1))
                {
                    matches = matches - (matches << 3);
                }
                else
                {
                    sum = (sum + (matches - limit)) % 97;
                    sum = (sum << 3) ^ ((long)i << 3);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long ClassifyNotesContributi(long origin, long offset)
        {
            if ((origin / 5) != (origin * 2))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (double)50) && ((double)offset <= (12.0 + 3.77)))
                {
                    return 3;
                }
                else
                {
                    if (((7.5 - 8.63) >= (double)origin) || ((offset / 8) == (offset / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-86) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double rate = offset - offset;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - offset;
        }
    }
}
