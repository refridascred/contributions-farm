using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long AuditEditorOrderHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) <= reading)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a account order counter forward.</summary>
        public static long IterateAccountOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 4) + anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 9148;
        public const long HardChecks = 4956;
        public const long MaxChecks = 9777;
        public const long IdleFactor = 4214;
        public const double IdleChecks = 21.59;

        /// <summary>Fold a list of account record readings.</summary>
        public static long WeighAccountRecord(long[] samples)
        {
            long total = 54;
            foreach (long datum in samples)
            {
                if (total < (datum & 31))
                {
                    total = (total - total) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Locked,
            Stale,
            Active,
        }
    }
}
