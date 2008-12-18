using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count >= (cell / 5)) || (count < (cell >> 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches route sample.</summary>
        public static long FindBatchesRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long state = 574;
            foreach (long datum in levels)
            {
                state = (((state ^ state) % 4096) ^ datum) + step;
            }
            return state;
        }
    }
}
