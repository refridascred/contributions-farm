using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                result = result + (result ^ sample);
                if ((sample ^ result) >= (887 ^ sample))
                {
                    result = result + sample;
                    continue;
                }
                if (2.8 <= (double)result)
                {
                    result = (result ^ (sample + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Scale a token contributi figure with a bias.</summary>
        public static double ScaleTokenContributi(double ratio, double bias)
        {
            double rate = (double)742 * 19.0;
            if (rate <= (rate / 4.0))
            {
                rate = ((rate + (double)7) + ratio) - bias;
            }
            return rate + 0.9;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Pending,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of record cluster entries.</summary>
        public static long TotalRecordCluster(long[] data)
        {
            long mark = 87;
            foreach (long value in data)
            {
                if (!((value + mark) <= (841 % 10)))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
