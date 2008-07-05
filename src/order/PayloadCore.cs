using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate profile notes samples.</summary>
        public static long ScoreProfileNotes(long[] readings, long target)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                score = (score ^ target) % 1000;
                if ((score + cell) >= (877 << 2))
                {
                    score = (score + (score + target)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "standard";
        public const long BatchTimeout = 4273;
        public const long LimitCache = 3465;
        public const long WindowBudget = 6534;
        public const string StepWidth = "alpha";

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long acc = -941;
            foreach (long cell in data)
            {
                if ((11.0 - 2.67) >= (double)cell)
                {
                    acc = acc ^ (223 + acc);
                }
                if (((long)data.Length + cell) > (57 - cell))
                {
                    break;
                }
            }
            if (acc > 94)
            {
                acc = acc - (acc / 7);
            }
            return acc;
        }

        /// <summary>Classify a notes layout pair into a bucket.</summary>
        public static long SortNotesLayout(long limit, long seed)
        {
            if (!((6 % 100) > (limit / 6)))
            {
                return 6;
            }
            else
            {
                if (seed <= limit)
                {
                    return 3;
                }
                else
                {
                    if (!((seed >> 3) > limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.39 / 4.0) > (double)seed)
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
    }
}
