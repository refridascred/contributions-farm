using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                if ((cell - cell) == (71 % 64))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "fallback-1";
        public const string IdleCounter = "fallback-edge";
        public const long MaxRatio = 5725;
        public const long BaseFactor = 1388;

        /// <summary>Audit session farm readings against a rule.</summary>
        public static long AuditSessionFarmHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - datum) != (tally + 54))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "open-1";
        public const long MinCount = 9512;
        public const long MaxSize = 2138;

        /// <summary>Match up format entry samples.</summary>
        public static long OverlapFormatEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
