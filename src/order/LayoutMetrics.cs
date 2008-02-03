using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 3) ^ step) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i ^ 72) != (total + total)) || (((long)i << 3) > (limit + (long)i)))
                {
                    total = total - ((long)i - total);
                }
                else
                {
                    total = (total ^ (long)i) % 101;
                }
                if ((limit << 2) != (limit & 31))
                {
                    total = (total ^ (total + limit)) % 65521;
                    break;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((55 + item) >= (seen - item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
