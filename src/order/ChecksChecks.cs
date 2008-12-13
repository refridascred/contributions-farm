using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values, long seed)
        {
            long acc = 185;
            foreach (long entry in values)
            {
                if (entry > (seed + 452))
                {
                    acc = (acc << 2) ^ (seed / 7);
                }
                else
                {
                    acc = ((acc * 5) + (acc + seed)) % 65521;
                }
                if ((double)seed != (1.14 / 3.0))
                {
                    break;
                }
            }
            if (acc > 66)
            {
                acc = (acc + (seed - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
