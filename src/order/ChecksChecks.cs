using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings)
        {
            long anchor = -8;
            foreach (long datum in readings)
            {
                if ((double)anchor <= 0.8)
                {
                    anchor = (((anchor * 2) + (anchor >> 1)) % 255) + datum;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 3) + ((long)readings.Length << 1)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ score;
                if ((58 << 3) > (score - offset))
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
