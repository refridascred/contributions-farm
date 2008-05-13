using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading + 0) < (reading + reading)) && ((count + reading) != (count / 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window metric readings.</summary>
        public static long CombineWindowMetric(long[] series, long limit)
        {
            long mix = 25;
            foreach (long cell in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix << 3) ^ ((long)i + mix)) % 1000;
                }
                if ((mix + (-6)) < (limit ^ mix))
                {
                    mix = ((mix * 5) + (cell % 64)) % 97;
                }
                else
                {
                    mix = (mix ^ limit) % 4096;
                }
                if ((cell - cell) >= mix)
                {
                    mix = (mix - mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
