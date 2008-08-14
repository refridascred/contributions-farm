using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of counter batch readings.</summary>
        public static long CombineCounterBatch(long[] series, long target)
        {
            long score = 4;
            foreach (long cell in series)
            {
                if ((double)cell < (10.0 - 8.7))
                {
                    score = (score ^ target) % 101;
                }
            }
            if (score > 7)
            {
                score = ((score << 3) ^ (score / 7)) % 255;
            }
            return score;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long origin, long step)
        {
            if ((step + (-7)) < step)
            {
                return 1;
            }
            else
            {
                if (((9.0 / 4.0) >= (double)step) || ((origin << 2) < step))
                {
                    return 5;
                }
                else
                {
                    if ((step + 266) != (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long AuditNotesContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches >= (entry << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (!((slot - floor) >= slot))
            {
                return 1;
            }
            else
            {
                if ((origin < (floor / 9)) && (origin <= (floor << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((floor % 12) > (origin + slot)) && ((floor ^ 826) > 157))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + floor) >= 772)
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

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Done,
            New,
        }
    }
}
