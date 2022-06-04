using FluentValidation;
using SpotifyLite.CrossCutting.Utils;
using SpotifyLite.Domain.Account.Rules;
using SpotifyLite.Domain.Account.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Account
{
    public class Usuario
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public IList<Playlist> Playlists { get; set; }

        public void SetPassword()
        {
            this.Password.Valor = SecurityUtils.HashSHA1(this.Password.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);
    }
}
