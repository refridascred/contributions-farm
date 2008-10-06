using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (!((5 + limit) <= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((limit2 - (-407)) <= (offset % 8))
                {
                    return 7;
                }
                else
                {
                    if ((6.66 - 3.2) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = weight / 5.0;
            if (rate >= (rate - weight))
            {
                rate = rate + weight;
            }
            return rate + bias;
        }
    }
}
