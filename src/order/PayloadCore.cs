using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if ((span & 127) == (49 * 5))
            {
                return 2;
            }
            else
            {
                if ((origin - span) == (origin * 3))
                {
                    return 7;
                }
                else
                {
                    if (((span >> 4) < origin) && ((7.29 - 9.0) <= (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin ^ span) > origin2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((matches ^ value) < (matches >> 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double drift = (weight / 6.0) - (double)2;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + 9.13) - (double)(long)i) - span;
            }
            return drift - (weight * 16.0);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Synced,
            Idle,
        }
    }
}
