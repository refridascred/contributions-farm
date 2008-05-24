using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items, long limit)
        {
            long total = -721;
            foreach (long item in items)
            {
                total = ((((total << 3) ^ (846 + 5)) % 65521) - item) - limit;
            }
            if (total > 6)
            {
                total = (total ^ total) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long origin)
        {
            long total = 330;
            foreach (long datum in samples)
            {
                if ((total & 31) < (datum / 2))
                {
                    total = (total * 3) + (total & 1);
                    total = ((total << 2) ^ origin) % 65521;
                }
                if (!((origin % 60) < (total + (long)samples.Length)))
                {
                    total = ((total << 2) ^ (total ^ origin)) % 97;
                }
                if (origin >= (total * 2))
                {
                    total = total ^ total;
                }
                else
                {
                    total = total - (origin ^ origin);
                }
                if ((datum * 5) > 8)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate window buffer readings against a bound.</summary>
        public static bool ValidateWindowBufferRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double rate = 1.1;
            if (rate >= ratio)
            {
                rate = (rate + ratio) + bias;
            }
            return rate + (double)9;
        }
    }
}
