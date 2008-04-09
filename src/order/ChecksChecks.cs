using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                long matches = 926;
                anchor = ((anchor << 2) ^ (matches - anchor)) % 4096;
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches > entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Ready,
            Stale,
        }
    }
}
