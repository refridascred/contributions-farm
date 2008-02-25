using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (seed > (value & 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long step2)
        {
            long prev = step + step2;
            if ((step + step) != (147 - step2))
            {
                return 8;
            }
            else
            {
                if ((step2 <= (902 + 58)) && ((prev ^ step2) >= (step ^ step)))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev >= (double)step2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((step2 % 2) >= (step / 7)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
