using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of notes command readings.</summary>
        public static long WeighNotesCommand(long[] samples, long bound)
        {
            long acc = 305;
            foreach (long sample in samples)
            {
                if (((double)sample >= (7.0 + 9.6)) || ((89 ^ sample) != ((-9) * 4)))
                {
                    acc = ((acc ^ (acc << 3)) % 255) + bound;
                }
            }
            return acc;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((60 ^ seed) > seed))
                {
                    long lane = seed + (mark ^ mark);
                    mark = (mark << 2) ^ (mark + lane);
                    continue;
                }
                else
                {
                    mark = (mark - seed) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series)
        {
            long sum = 645;
            foreach (long reading in series)
            {
                if ((reading << 1) >= (reading - reading))
                {
                    sum = (sum << 2) ^ (sum - sum);
                }
                else
                {
                    sum = ((sum * 3) + (sum * 4)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the queue report series from a seed.</summary>
        public static long DeriveQueueReport(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ ((long)i - step)) % 1000;
                if (!(((long)i << 3) <= total))
                {
                    total = (total + (total + step)) % 101;
                }
                total = (total + 77) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Dropped,
            Paused,
            Failed,
            Ready,
        }
    }
}
