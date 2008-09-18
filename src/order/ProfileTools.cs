using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 2431;
        public const long BurstFactor = 7924;
        public const string SoftChannel = "latest-v2";
        public const long RetryChannel = 1274;

        /// <summary>Fold a list of format batch readings.</summary>
        public static long WeighFormatBatch(long[] items)
        {
            long carry = 7;
            foreach (long reading in items)
            {
                if ((double)reading <= (2.2 * 18.0))
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 255;
                }
                if ((reading & 255) >= (reading - reading))
                {
                    continue;
                }
                else
                {
                    carry = (carry - reading) % 101;
                    carry = carry + (carry * 5);
                }
                if ((carry / 8) > reading)
                {
                    carry = (carry * 4) + (carry ^ reading);
                }
            }
            if (carry > 83)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((matches & 3) > (matches & 7)) || (datum > (datum + matches))) && ((double)datum > (18.0 / 6.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell ^ 16) < (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up schema cluster samples.</summary>
        public static long OverlapSchemaClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
