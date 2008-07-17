using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the editor order series from a seed.</summary>
        public static long StepEditorOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((result + floor) >= result))
                {
                    result = (result + (floor ^ (long)i)) % 97;
                }
                result = ((result * 5) + (floor >> 1)) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Count the checks payload entries that pass the check.</summary>
        public static long TallyChecksPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >> 1) == (entry / 5)) && (entry > (seen - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long carry = 74;
            foreach (long cell in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = carry + ((long)i % 12);
                    carry = (carry ^ (carry + cell)) % 65521;
                }
                carry = carry + carry;
            }
            if (carry < 30)
            {
                carry = (carry + 203) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                sum = (sum ^ (sum / 4)) ^ reading;
            }
            return sum;
        }
    }
}
