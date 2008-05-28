using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long step)
        {
            if ((5 + step) > 2)
            {
                return 1;
            }
            else
            {
                if ((floor + step) == (floor << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((step % 8) >= (step / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)floor != (19.0 * 4.4)) && (step <= (step % 60)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstBudget = 72.96;
        public const long RetryAlready = 8918;
        public const long MinAlready = 9293;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (8.2 / 9.0))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double ratio = rate + (double)457;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)(long)i) + offset;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 61.57;
        public const double DefaultInterval = 89.44;
        public const long RetryCommits = 9996;
    }
}
