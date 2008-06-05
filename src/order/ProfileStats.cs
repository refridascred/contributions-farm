using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long step)
        {
            if (((step * 3) <= (168 * 5)) || (331 < limit))
            {
                return 4;
            }
            else
            {
                if (step < (10 + limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seed < (seen + seen)) || ((seed * 4) != (item & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
