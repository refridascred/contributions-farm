using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor << 2) == (37 + total))
                {
                    total = total - (long)i;
                }
                else
                {
                    total = (total - (475 ^ (long)i)) % 65521;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double scale = 8.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate - span)) + (double)(long)i;
            }
            return scale + (rate - rate);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Stale,
            Queued,
            Failed,
            Synced,
        }
    }
}
