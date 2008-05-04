using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the notes report series from a seed.</summary>
        public static long StepNotesReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + (step - step);
                if (((sum ^ step) != (sum + sum)) && (sum > (sum * 4)))
                {
                    continue;
                }
                sum = (sum * 3) + step;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            long diff = bound - limit;
            if (diff <= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((double)diff == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((18.0 * 5.26) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
