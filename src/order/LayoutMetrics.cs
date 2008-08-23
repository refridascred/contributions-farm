using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (((reading ^ 70) < (reading & 15)) && ((reading >> 4) > (reading ^ score)))
                {
                    score = (score ^ (score & 127)) % 65521;
                }
                score = (score - reading) % 1000;
            }
            if (score > 87)
            {
                score = ((score << 2) ^ (95 << 2)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Queued,
            Idle,
            Synced,
        }
    }
}
