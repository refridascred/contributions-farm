using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a command editor counter forward.</summary>
        public static long IterateCommandEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(75 >= bound))
                {
                    result = (result * 5) + result;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step / 2) != (step - 935))
                {
                    result = ((result * 3) + (step + step)) % 1000;
                    result = (result * 5) + 660;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a batch account counter forward.</summary>
        public static long SeriesBatchAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset % 64) >= (sum - (long)i))
                {
                    sum = (sum + (offset + sum)) % 97;
                    break;
                }
                else
                {
                    sum = ((sum * 4) + ((long)i >> 4)) % 97;
                    sum = (sum - (offset + (long)i)) % 65521;
                }
                sum = ((sum << 2) ^ offset) % 97;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((seed - hits) != (hits * 4))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
