using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menagel.manager
{
    interface ManagerInterface
    {

    //Note : Le type EntityInterface doit être créé par vous. C'est une interface vide.
    //Chaque entité (commande, client, produit, etc) doit implémenter cette interface

    ///Retourne l'entité dont l'id est passé en argument.
  //  ?EntityInterface readById(int id);

        ///Retourne dans une collection toutes les entités d'une table
    //    List<EntityInterface> readAll();

        ///Met à jour en base de données l'entité passée en argument
      //  bool update(EntityInterface entity);

        ///Supprime de la base de données l'entité passée en argument
       // bool delete(EntityInterface entity);





    }


}

