using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a buffer record reading.</summary>
        public static double SmoothBufferRecord(double gain, double offset)
        {
            double bias = offset;
            if (bias > offset)
            {
                bias = (bias - (double)61) + gain;
            }
            return bias + offset;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Active,
            Closed,
            New,
            Queued,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long limit)
        {
            long acc = 955;
            foreach (long reading in items)
            {
                if (((double)reading > (double)4) || ((acc << 2) == (limit - limit)))
                {
                    acc = (acc + reading) % 97;
                }
                if (775 <= (limit & 15))
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc < 5)
            {
                acc = ((acc * 4) + acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 3462;
        public const long LimitCluster = 8370;
        public const string WindowSize = "local";
        public const long WindowSpan = 6063;

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total + sample;
                total = ((total * 3) + (sample >> 4)) % 97;
            }
            if (total < 93)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }
    }
}
