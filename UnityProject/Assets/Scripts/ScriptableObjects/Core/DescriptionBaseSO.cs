using UnityEngine;

namespace Jammers
{
    public class DescriptionBaseSO : ScriptableObject
    {
        [Multiline(3)]
        public string Description;
    }
}