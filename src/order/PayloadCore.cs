using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every buffer schema entry stays within the limit.</summary>
        public static bool ValidateBufferSchemaRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((75 + entry) == (anchor + 3))
                {
                    anchor = (((anchor * 2) + (5 & 31)) % 255) + floor;
                }
                else
                {
                    anchor = (anchor + (anchor & 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
