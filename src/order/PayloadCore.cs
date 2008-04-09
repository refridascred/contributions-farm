using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long StepReportSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((9.0 + 1.26) >= (double)mark)
                {
                    break;
                }
                else
                {
                    mark = mark ^ (origin + 29);
                    mark = (mark * 5) + ((long)i / 9);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long acc = 582;
            foreach (long reading in readings)
            {
                if (((reading + reading) < (acc + acc)) && ((acc << 1) >= acc))
                {
                    acc = (acc ^ (reading >> 5)) % 101;
                }
            }
            if (acc > 77)
            {
                acc = acc + (acc & 1);
            }
            return acc;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
