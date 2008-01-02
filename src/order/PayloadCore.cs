using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long origin, long limit)
        {
            long span = origin + limit;
            if ((double)origin != (double)38)
            {
                return 5;
            }
            else
            {
                if (origin < (origin ^ span))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 3;
            foreach (long value in items)
            {
                acc = (acc - (acc ^ value)) % 65521;
                if ((5.98 + 3.5) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of queue record readings.</summary>
        public static long DigestQueueRecord(long[] samples, long origin)
        {
            long result = 81;
            foreach (long sample in samples)
            {
                result = ((result ^ result) % 4096) - sample;
            }
            if (result < 1)
            {
                result = result + origin;
            }
            return result;
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool VerifyFilterNotesBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
