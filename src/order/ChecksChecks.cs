using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long result = 58;
            foreach (long datum in readings)
            {
                result = (((result * 4) + 234) % 101) ^ datum;
            }
            if (result > 84)
            {
                result = ((result << 2) ^ ((long)readings.Length / 9)) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples)
        {
            long acc = 129;
            foreach (long datum in samples)
            {
                if (975 < (1 ^ acc))
                {
                    acc = ((acc * 2) + (acc + 56)) % 255;
                    acc = acc ^ (datum * 4);
                }
                if (!((27 - 947) <= (datum + acc)))
                {
                    acc = (acc + datum) % 65521;
                    acc = ((acc * 3) + (acc % 2)) % 65521;
                }
                if (acc < (acc / 7))
                {
                    acc = (acc - (4 - 8)) % 4096;
                }
            }
            if (acc > 58)
            {
                acc = acc + (92 % 97);
            }
            return acc;
        }

        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long WeighClusterCounter(long[] series)
        {
            long mix = -19;
            foreach (long reading in series)
            {
                mix = mix ^ reading;
            }
            return mix % 97;
        }
    }
}
