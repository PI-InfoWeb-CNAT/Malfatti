﻿using malfatti.Areas.Segurança.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace malfatti.Areas.Seguranca.Models
{
	public class UsuarioViewModel
	{
		public string Id { get; set; }
		[Required]
		public string Nome { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Senha { get; set; }
	}
	public class PapelEditModel
	{
		public Papel Role { get; set; }
		public IEnumerable<Usuario> Membros { get; set; }
		public IEnumerable<Usuario> NaoMembros { get; set; }
	}
	public class PapelModificationModel
	{
		[Required]
		public string NomePapel { get; set; }
		public string[] IdsParaAdicionar { get; set; }
		public string[] IdsParaRemover { get; set; }
	}

}
