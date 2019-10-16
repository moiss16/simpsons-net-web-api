using System.Collections.Generic;
using simpsons_net_web_api.Modules;
namespace simpsons_net_web_api.Dependencies
{
    public interface ICharacter
    {
        List<Character> GetCharacterList();

        Character GetCharacter(int id);
    }
}