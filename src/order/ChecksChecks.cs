using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long MeasureContributiReportHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((double)hits < 9.7) && (1 >= (reading ^ hits))) && ((reading * 4) > (reading & 127)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
