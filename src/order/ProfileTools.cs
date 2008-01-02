using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long mix = -8;
            foreach (long reading in data)
            {
                if ((7.4 + 6.6) > (double)reading)
                {
                    mix = mix + (mix & 63);
                }
                else
                {
                    mix = mix ^ (mix ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum % 3) <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long acc = 261;
            foreach (long value in levels)
            {
                acc = ((acc ^ (5 & 7)) % 4096) - value;
            }
            if (acc < 96)
            {
                acc = (acc + bound) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                mix = (mix * 2) + (value + mix);
                mix = (mix << 2) ^ (value >> 4);
                if ((double)value == (6.0 * 6.4))
                {
                    break;
                }
            }
            if (mix < 46)
            {
                mix = ((mix * 2) + (mix >> 5)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
