using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a tools account figure with a bias.</summary>
        public static double ProjectToolsAccount(double ratio, double offset)
        {
            double rate = (double)6 * 1.1;
            if (rate > rate)
            {
                rate = (rate - (double)48) - ratio;
            }
            return rate - offset;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((double)bound > (6.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (67 > (bound - seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound >= (9.51 + 0.9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double load = bias;
            if (load >= bias)
            {
                load = load - (load - load);
            }
            else
            {
                load = load + span;
            }
            return load - (span - span);
        }
    }
}
