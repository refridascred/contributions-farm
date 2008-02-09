using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum - 7) % 65521;
                if (sum > (cell / 4))
                {
                    sum = sum + (sum * 2);
                }
                if ((-48) > cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Closed,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples, long limit)
        {
            long mark = 274;
            foreach (long entry in samples)
            {
                mark = (mark + (entry + entry)) % 255;
                mark = mark - (56 + limit);
            }
            return mark;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long bound)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                anchor = (anchor - anchor) ^ value;
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ bound;
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next checks tools value from a seed.</summary>
        public static long IterateChecksTools(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (result - result)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
