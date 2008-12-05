using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits >= (double)152)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long seed)
        {
            if (!((double)step == (5.5 - 9.64)))
            {
                return 6;
            }
            else
            {
                if ((4.92 / 6.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if (step <= (seed - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ step) != (8 + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema tools readings against a bound.</summary>
        public static bool CheckSchemaToolsRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
