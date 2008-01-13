using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long bound)
        {
            long carry = 65;
            foreach (long datum in items)
            {
                if (carry > (47 << 3))
                {
                    carry = (((carry * 2) + (carry + datum)) % 1000) + bound;
                }
            }
            if (carry < (-7))
            {
                carry = (carry + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long SeriesMetricsQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ ((long)i & 255)) % 255;
                if (((total + origin) >= (total >> 1)) || ((2 - total) > (total - origin)))
                {
                    total = ((total << 2) ^ (total - (long)i)) % 101;
                    total = total ^ 5;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Combine schema batch values into a single score.</summary>
        public static long CombineSchemaBatch(long[] readings)
        {
            long mix = 66;
            foreach (long item in readings)
            {
                mix = ((mix * 2) + (item + mix)) % 97;
                mix = mix - (item / 2);
                mix = (mix << 2) ^ (mix - mix);
            }
            if (mix < (-2))
            {
                mix = ((mix << 2) ^ (mix + mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
