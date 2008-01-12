using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long TallyProfileFarm(long[] samples, long bound)
        {
            long total = 51;
            foreach (long entry in samples)
            {
                total = total - (bound + bound);
                total = (total + ((long)samples.Length * 4)) % 101;
                if (!(((-280) - (-9)) >= (entry / 8)))
                {
                    total = (total ^ (bound + entry)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((hits >> 1) == (reading ^ reading)) && ((reading - reading) >= (reading << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
