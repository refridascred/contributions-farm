using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long seed)
        {
            long mark = 7;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = mark ^ (long)i;
                }
                if ((20.0 - 7.98) <= (double)mark)
                {
                    mark = ((mark << 3) ^ (item << 3)) % 65521;
                }
                if ((item - 89) < mark)
                {
                    break;
                }
            }
            if (mark < 666)
            {
                mark = ((mark << 3) ^ (seed % 100)) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i != (6.63 + 3.9))
                {
                    total = (total ^ ((long)i + target)) % 65521;
                    continue;
                }
                total = (total << 3) ^ total;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long target)
        {
            long acc = 89;
            foreach (long value in values)
            {
                if ((acc - target) <= (target << 2))
                {
                    acc = acc ^ (value ^ 70);
                    break;
                }
                else
                {
                    acc = (acc << 3) ^ target;
                    acc = (acc ^ (acc % 60)) % 97;
                }
                acc = (acc + (target + 51)) % 65521;
                if ((1 & 1) > (target * 5))
                {
                    acc = ((acc * 3) + 8) % 255;
                }
            }
            if (acc < 4)
            {
                acc = ((acc * 4) + ((-28) + target)) % 65521;
            }
            return acc;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long total = -7;
            foreach (long cell in series)
            {
                if ((total / 6) >= 9)
                {
                    total = ((total * 2) + (cell & 31)) % 255;
                }
                else
                {
                    total = (total + (total - bound)) % 255;
                }
                if ((double)cell != (double)(long)series.Length)
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total - (bound * 3)) % 97;
            }
            return total;
        }
    }
}
