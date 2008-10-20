using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items, long seed)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                if (!((double)acc == (19.0 - 3.4)))
                {
                    acc = ((acc + (926 + seed)) % 255) ^ datum;
                }
            }
            if (acc > 8)
            {
                acc = (acc + seed) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + step) > (step % 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor buffer readings against a bound.</summary>
        public static bool CheckEditorBufferLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
