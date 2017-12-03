/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicios;

import Entidades.VentasBackup;
import Entidades.VentasBackupJpaController;
import java.math.BigDecimal;
import java.math.BigInteger;
import java.util.List;
import javax.annotation.Resource;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.persistence.EntityManager;
import javax.persistence.NamedQuery;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;
import javax.persistence.criteria.CriteriaQuery;
import javax.transaction.UserTransaction;

/**
 *
 * @author PC-Cristopher
 */
@WebService(serviceName = "NewWebService")
public class NewWebService {

    @PersistenceContext
    EntityManager em;

    @Resource
    UserTransaction utx;

    @WebMethod
    public List<VentasBackup> listarVentas() {
        CriteriaQuery cq = em.getCriteriaBuilder().createQuery();
        cq.select(cq.from(VentasBackup.class));
        Query q = em.createQuery(cq);
        return q.getResultList();
    }

    @WebMethod
    public int buscarVenta(@WebParam(name = "id") int id) {
        try {
            VentasBackup v = em.find(VentasBackup.class, new BigDecimal(id + ""));
            System.out.println("v " + v.getIdRes().toString());
            return 1;
        } catch (Exception e) {
            return 0;
        }
    }

    @WebMethod
    public int crearVenta(@WebParam(name = "idd") int idd, @WebParam(name = "subtot") int subtot, @WebParam(name = "propin") int propin, @WebParam(name = "total_r") int total_r, @WebParam(name = "pedido_id") int pedido_id) {
        try {
            System.out.println("askudais");
            VentasBackup p = new VentasBackup(new BigDecimal(idd + ""), new BigInteger(propin + ""), new BigInteger(propin + ""), new BigInteger(total_r + ""), new BigInteger(pedido_id + ""));
            p.setSubtotalRes(new BigInteger(subtot + ""));
            p.setPropinaRes(new BigInteger(propin + ""));
            p.setTotalRes(new BigInteger(total_r + ""));
            p.setPedidoidRes(new BigInteger(pedido_id + ""));

            utx.begin();
            em.persist(p);
            utx.commit();
            return 1;
        } catch (Exception ex) {
            System.out.println("Error ");
            System.out.println(ex.getMessage());
        }

        return 0;
    }
}
